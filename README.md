## 📝 README.md — Projeto Screen Sound

### 🎯 Sobre o Projeto

Este é um projeto em C# feito com Console Application, que simula uma estrutura de gerenciamento de:

- 🎧 Podcasts e seus episódios
- 🎵 Bandas, álbuns e músicas

Ele permite adicionar informações e exibir os dados de forma estruturada no terminal, com foco em prática de orientação a objetos.

---

### 📂 Estrutura do Projeto

O projeto é composto pelas seguintes classes:

- `Banda`: representa uma banda musical, podendo conter vários álbuns.
- `Album`: representa um álbum com várias músicas e duração total.
- `Musica`: contém informações sobre uma música, como duração e disponibilidade.
- `Podcast`: representa um podcast com vários episódios.
- `Episodio`: armazena os dados de um episódio do podcast, incluindo convidados.

---

### 🚀 Como Usar

1. **Clone o repositório ou copie os arquivos para seu ambiente local.**

2. **Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.**

3. **Abra o terminal na pasta do projeto e execute:**

```bash
dotnet run
```

Isso irá executar a aplicação console e exibir informações dos episódios do podcast adicionados manualmente no código.

---

### 📌 Exemplo de Saída

```txt
Podcast Podcast Coding apresentado por João

1. Técnicas de Marketing (30 min) - João, Geovana, Pedro
2. Técnicas de aprendizado (61 min) - Pedro, Jorge, Guilherme
3. Técnicas de facilitação (45 min) - João, Geovana

Esse podcast possui 3 episódios.
```

---

### 🛠️ Funcionalidades Implementadas

- Adição de músicas a um álbum
- Adição de álbuns a uma banda
- Exibição de discografia
- Exibição da ficha técnica de músicas
- Criação de episódios de podcast com múltiplos convidados
- Exibição detalhada do podcast com ordem correta dos episódios

---

### ✅ Tecnologias Utilizadas

- C#
- .NET Console Application
- Paradigma de Programação Orientada a Objetos

