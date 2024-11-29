import pandas as pd
import importlib.resources
import flet as ft

def main(page: ft.Page):
    page.title = "TerrasMil - Fazenda Urbana"
    page.theme_mode = ft.ThemeMode.LIGHT

    # Carregar dados do Excel
    file_path = importlib.resources.files("helloworld.resources").joinpath("base_dados.xlsx")
    usuarios_df = pd.read_excel(file_path, sheet_name="USUARIOS")

    # Carregar imagem de fundo
    img_path = importlib.resources.files("helloworld.resources").joinpath("fazendas.jpg")
    background_image = ft.Image(
        src=f"file://{img_path.resolve()}",  # Caminho absoluto para a imagem
        opacity=0.3,
        fit=ft.ImageFit.COVER,
        width=page.width,
        height=page.height,
    )

    # Elementos de login
    login_input = ft.TextField(label="Digite seu CPF:", width=300)
    login_button = ft.ElevatedButton("Entrar")
    login_error = ft.Text(color="red")

    # Layout da página
    page.add(
        ft.Stack(
            controls=[
                background_image,
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
                    height=page.height,
                ),
            ]
        )
    )

if __name__ == "__main__":
    ft.app(target=main)
