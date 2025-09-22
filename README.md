# 🌡️ Conversor de Temperaturas — .NET MAUI (C#)

![.NET](https://img.shields.io/badge/.NET%20MAUI-8A2BE2?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

---

## Descrição
Aplicação simples em **.NET MAUI** utilizando o padrão **MVVM (Model-View-ViewModel)**.  

O app permite ao usuário:  
- Selecionar o tipo de conversão (Celsius ↔ Fahrenheit)  
- Inserir um valor numérico  
- Receber automaticamente o resultado da conversão via **data binding**  

> Objetivo: demonstrar de forma prática o uso de **Bindings**, **Commands** e **MVVM** em uma aplicação .NET MAUI.

---

## Principais recursos
- Conversão **Celsius ↔ Fahrenheit**  
- Interface simples com **Label, Entry, Picker e Button**  
- Uso de **INotifyPropertyChanged** para atualização automática da UI  
- Comandos para **Converter** e **Limpar** campos  
- Suporte a vírgula ou ponto para decimais

---

## Pré-requisitos
- **Windows 10/11**  
- **Visual Studio 2022+** com carga de trabalho **“.NET Multi-platform App UI development (MAUI)”**  
  - Inclui Android SDKs e Emulador Android  
- **.NET SDK** compatível com MAUI já instalado  
- (Opcional) **Dispositivo Android** ou emulador configurado  
- (Opcional – macOS) Para compilar iOS/MacCatalyst, é necessário ambiente Apple  

dotnet workload install maui

## Como obter o projeto

### Opção 1 — Git (recomendado)
- git clone https://github.com/seu-usuario/seu-repo.git
- cd seu-repo

### Opção 2 — Download
- Baixe o .zip do repositório
- Extraia em uma pasta local
- Abra o .sln no Visual Studio

---

## 🔧 Executando o App
1. Abra a solução no Visual Studio  
2. Selecione o destino:
   - Android Emulator
   - Windows Machine (WinUI 3)
   - Dispositivo físico Android  
3. Clique em **Run/Play (F5)**

---

## 📝 Como Usar
- Selecione o tipo de conversão no **Picker**  
- Digite o valor a ser convertido no campo **Entry**  
- Clique em **Converter**  
- O resultado aparecerá automaticamente no **Label**  
- Clique em **Limpar** para resetar os campos  

> Dica: use vírgula ou ponto para decimais (ex.: 21,3 ou 21.3)

---

## 🏗️ Estrutura MVVM
- **View (MainPage.xaml)** → Define a interface do usuário  
- **ViewModel (MainViewModels.cs)** → Gerencia lógica, comandos e propriedades  
- **Model (MainModels.cs)** → Contém a lógica de conversão  
- **BindingContext (MainPage.xaml.cs)** → Conecta a View ao ViewModel  

---

## 📌 Exemplos de Conversão
| Entrada | Conversão Selecionada   | Resultado          |
|---------|-------------------------|------------------|
| 25      | Celsius → Fahrenheit    | 25 °C = 77 °F    |
| 100     | Fahrenheit → Celsius    | 100 °F = 37,78 °C|

---

## 📁 Estrutura do Projeto

/ConversorTemperaturas
├─ MainPage.xaml
├─ MainPage.xaml.cs
├─ MainViewModels.cs
├─ MainModels.cs
└─ App.xaml

---

## 🚀 Roadmap
- Melhorar interface com cores e estilos  
- Adicionar internacionalização (pt-BR, en-US)  
- Criar testes unitários para o ViewModel  

---

## 🤝 Contribuindo
- Fork  
- Crie uma branch: `feat/sua-melhoria`  
- Commit  
- Pull Request  

---

📜 **Licença**
- Este projeto está sob a licença MIT. Veja LICENSE para mais detalhes.
