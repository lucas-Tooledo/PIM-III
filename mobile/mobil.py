import pandas as pd

import flet as ft

# Carrega os dados do Excel
file_path = 'base_dados.xlsx'
usuarios_df = pd.read_excel(file_path, sheet_name="USUARIOS")

# Função principal da aplicação
def main(page: ft.Page):
    page.title = "TerrasMil - Fazenda Urbana"
    page.theme_mode = ft.ThemeMode.LIGHT

    # Variável para armazenar o ID do usuário logado
    usuario_logado = None

    # Elementos da tela de login
    login_input = ft.TextField(label="Digite seu CPF:", width=300)
    login_button = ft.ElevatedButton("Entrar")
    login_error = ft.Text(color="red")

    # Tabela de dados e elementos de pesquisa globais para uso em várias funções
    global data_table, search_input, search_button
    data_table = ft.Column(scroll=ft.ScrollMode.AUTO, expand=True)
    search_input = ft.TextField(label="Pesquisar", width=200)
    search_button = ft.IconButton(icon=ft.icons.SEARCH)

    # Função para autenticar o usuário
    def autenticar_usuario(e):
        nonlocal usuario_logado
        usuario_cpf = login_input.value

        # Verifica se o ID do usuário está na planilha de usuários
        if float(usuario_cpf) in usuarios_df['CPF'].values:
            usuario_logado = usuarios_df[usuarios_df['CPF'] == float(usuario_cpf)].iloc[0]
            page.clean()  # Limpa a página e exibe a landing page
            mostrar_landing_page()
        else:
            login_error.value = "CPF inválido. Tente novamente."
            page.update()

    # Associa a função de autenticação ao botão de login
    login_button.on_click = autenticar_usuario

    # Função para carregar e formatar dados de uma aba específica
    def carregar_dados(sheet_name):
        df = pd.read_excel(file_path, sheet_name=sheet_name)
        return df

    # Função para exibir os dados em um formato de tabela
    def exibir_tabela(df):
        columns = [ft.DataColumn(ft.Text(col)) for col in df.columns]
        rows = [
            ft.DataRow(cells=[ft.DataCell(ft.Text(str(cell))) for cell in row])
            for row in df.values
        ]
        return ft.DataTable(columns=columns, rows=rows, width=page.width)

    # Função para pesquisar dados na tabela atual
    def pesquisar_dados(sheet_name, termo_pesquisa):
        df = carregar_dados(sheet_name)
        df_filtrado = df[df.apply(lambda row: row.astype(str).str.contains(termo_pesquisa, case=False).any(), axis=1)]
        return df_filtrado

    # Função para mostrar a tabela selecionada
    def mostrar_dados(sheet_name):
        def atualizar_tabela(e=None):
            termo_pesquisa = search_input.value
            df = carregar_dados(sheet_name) if not termo_pesquisa else pesquisar_dados(sheet_name, termo_pesquisa)
            data_table.controls.clear()
            data_table.controls.append(exibir_tabela(df))
            page.update()

        search_button.on_click = atualizar_tabela
        atualizar_tabela()  # Carrega a tabela na inicialização

    # Função para exibir a tela principal com as abas
    def mostrar_tela_principal():
        page.clean()

        global tabs
        tabs = ft.Tabs(
            selected_index=0,
            tabs=[
                ft.Tab(text="Clientes"),
                ft.Tab(text="Fornecedores"),
                ft.Tab(text="Tarefas"),
                ft.Tab(text="Produção"),
            ],
            on_change=lambda e: [
                mostrar_dados("CLIENTE") if e.control.selected_index == 0 else None,
                mostrar_dados("FORNECEDOR") if e.control.selected_index == 1 else None,
                mostrar_dados("TAREFAS") if e.control.selected_index == 2 else None,
                mostrar_dados("PRODUÇÃO") if e.control.selected_index == 3 else None,
            ],
            width=page.width
        )

        # Texto de boas-vindas
        bem_vindo_text = ft.Text(f"Bem-vindo, {usuario_logado['NOME']}", size=20)

        # Botão de logout
        def logout(e):
            page.clean()
            mostrar_tela_login()

        logout_button = ft.ElevatedButton("Logout", on_click=logout)

        # Adiciona o conteúdo da tela principal e exibe dados da aba "Clientes" ao iniciar
        page.add(
            ft.Column(
                controls=[bem_vindo_text, logout_button, tabs, ft.Row(controls=[search_input, search_button]), data_table],
                alignment=ft.MainAxisAlignment.START,
                width=page.width,
                height=page.height
            )
        )

        # Exibe dados da primeira aba "Clientes" ao iniciar
        mostrar_dados("CLIENTE")

    # Tela de login com imagem de fundo opaca
    def mostrar_tela_login():
        page.add(
            ft.Stack(
                controls=[
                    ft.Image(src="fazendas.jpg", opacity=0.3, fit=ft.ImageFit.COVER, width=page.width, height=page.height),
                    ft.Column(
                        controls=[
                            ft.Text("Login", size=24),
                            login_input,
                            login_button,
                            login_error,
                        ],
                        alignment=ft.MainAxisAlignment.CENTER,
                        horizontal_alignment=ft.CrossAxisAlignment.CENTER,
                        width=page.width,
                        height=page.height
                    ),
                ]
            )
        )

    # Tela inicial da landing page após login com imagem de fundo opaca
    def mostrar_landing_page():
        page.add(
            ft.Stack(
                controls=[
                    ft.Image(src="fazendas.jpg", opacity=0.3, fit=ft.ImageFit.COVER, width=page.width, height=page.height),
                    ft.Column(
                        controls=[
                            ft.Text("Bem-vindo à TerrasMil", size=30, weight="bold"),
                            ft.Text(
                                "TerrasMil é uma fazenda urbana comprometida com práticas sustentáveis e a produção de alimentos frescos para nossa comunidade.\n"
                                "Nossos valores incluem inovação, sustentabilidade e responsabilidade com o meio ambiente. Estamos orgulhosos de nossa equipe que "
                                "trabalha para oferecer o melhor todos os dias.",
                                size=18,
                                text_align="center"
                            ),
                            ft.ElevatedButton("Acessar dados", on_click=lambda e: page.clean() or mostrar_tela_principal())
                        ],
                        alignment=ft.MainAxisAlignment.CENTER,
                        horizontal_alignment=ft.CrossAxisAlignment.CENTER,
                        spacing=20,
                        width=page.width,
                        height=page.height
                    ),
                ]
            )
        )

    # Mostra a tela de login ao iniciar
    mostrar_tela_login()

if __name__ == "__main__":
    ft.app(target=main)
