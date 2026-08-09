const container = document.getElementById("games-container");

async function loadGames() {

    const response = await fetch("http://localhost:5222/games");

    const games = await response.json();

    container.innerHTML = "";

    games.forEach(game => {

        const card = document.createElement("div");

        card.classList.add("game-card");

        card.innerHTML = `
            <h2>${game.title}</h2>
            <p>Gênero: ${game.genre}</p>
            <p>Preço: R$ ${game.price}</p>
        `;

        container.appendChild(card);
    });
}



searchGames = async () => {
    const searchInput = document.getElementById("search").value.toLowerCase();

    const response = await fetch(`http://localhost:5222/games/search?query=${searchInput}`);
    

    const games = await response.json();

    container.innerHTML = "";
    
    games.forEach(game => {

        const card = document.createElement("div");

        card.classList.add("game-card");

        card.innerHTML = `
            <h2>${game.title}</h2>
            <p>Gênero: ${game.genre}</p>
            <p>Preço: R$ ${game.price}</p>
        `;

        container.appendChild(card);
    });
}

loadGames();
searchGames();
