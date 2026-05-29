const API = "http://localhost:5174";

let todosMangas = [];

function carregarMangas() {
    fetch(API + "/mangas")
        .then(res => res.json())
        .then(mangas => {
            todosMangas = mangas;
        });
}

// 🔹 Mostra na tela
function mostrarMangas(lista) {
    const container = document.getElementById("lista-mangas");
    container.innerHTML = "";

    lista.forEach(manga => {
        const btn = document.createElement("button");
        btn.innerText = manga;
        btn.classList.add("manga-item");

        btn.onclick = () => carregarCapitulo(manga);

        container.appendChild(btn);
    });
}


document.getElementById("busca").addEventListener("input", function () {
    const texto = this.value.toLowerCase();
    const container = document.getElementById("lista-mangas");

    if (texto.length === 0) {
        container.innerHTML = "<p>Digite algo para buscar</p>";
        return;
    }

    const filtrados = todosMangas.filter(manga =>
        manga.toLowerCase().includes(texto)
    );

    if (filtrados.length === 0) {
        container.innerHTML = "<p>Nenhum manga encontrado</p>";
        return;
    }

    mostrarMangas(filtrados);
});


// 🔹 Carregar capítulo
function carregarCapitulo(manga) {
    const capitulo = "cap1";

    fetch(`${API}/manga/${manga}/${capitulo}`)
        .then(res => res.json())
        .then(imagens => {
            const container = document.getElementById("conteudo");
            container.innerHTML = "";

            imagens.forEach(url => {
                const img = document.createElement("img");
                img.src = API + url;
                container.appendChild(img);
            });
        });
}

mostrarMangas([]); // começa vazio
carregarMangas();