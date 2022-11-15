const menu = [
  {
    id: 1,
    title: "buttermilk pancakes",
    category: "breakfast",
    price: 15.99,
    img: "./images/item-1.jpg",
    desc: `I'm baby woke mlkshk wolf bitters live-edge blue bottle, hammock freegan copper mug whatever cold-pressed `,
  },
  {
    id: 2,
    title: "diner double",
    category: "lunch",
    price: 13.99,
    img: "./images/item-2.jpg",
    desc: `vaporware iPhone mumblecore selvage raw denim slow-carb leggings gochujang helvetica man braid jianbing. Marfa thundercats `,
  },
  {
    id: 3,
    title: "godzilla milkshake",
    category: "shakes",
    price: 6.99,
    img: "./images/item-3.jpg",
    desc: `ombucha chillwave fanny pack 3 wolf moon street art photo booth before they sold out organic viral.`,
  },
  {
    id: 4,
    title: "country delight",
    category: "breakfast",
    price: 20.99,
    img: "./images/item-4.jpg",
    desc: `Shabby chic keffiyeh neutra snackwave pork belly shoreditch. Prism austin mlkshk truffaut, `,
  },
  {
    id: 5,
    title: "egg attack",
    category: "lunch",
    price: 22.99,
    img: "./images/item-5.jpg",
    desc: `franzen vegan pabst bicycle rights kickstarter pinterest meditation farm-to-table 90's pop-up `,
  },
  {
    id: 6,
    title: "oreo dream",
    category: "shakes",
    price: 18.99,
    img: "./images/item-6.jpg",
    desc: `Portland chicharrones ethical edison bulb, palo santo craft beer chia heirloom iPhone everyday`,
  },
  {
    id: 7,
    title: "bacon overflow",
    category: "breakfast",
    price: 8.99,
    img: "./images/item-7.jpg",
    desc: `carry jianbing normcore freegan. Viral single-origin coffee live-edge, pork belly cloud bread iceland put a bird `,
  },
  {
    id: 8,
    title: "american classic",
    category: "lunch",
    price: 12.99,
    img: "./images/item-8.jpg",
    desc: `on it tumblr kickstarter thundercats migas everyday carry squid palo santo leggings. Food truck truffaut  `,
  },
  {
    id: 9,
    title: "quarantine buddy",
    category: "shakes",
    price: 16.99,
    img: "./images/item-9.jpg",
    desc: `skateboard fam synth authentic semiotics. Live-edge lyft af, edison bulb yuccie crucifix microdosing.`,
  },
  {
    id: 10,
    title: "bison steak",
    category: "dinner",
    price: 22.99,
    img: "./images/item-10.jpg",
    desc: `skateboard fam synth authentic semiotics. Live-edge lyft af, edison bulb yuccie crucifix microdosing.`,
  },
];//array com os produtos

const sectionCenter = document.querySelector(".section-center");//seção para adicionar os produtos
const container = document.querySelector(".btn-container");//botões

//load
window.addEventListener("DOMContentLoaded",()=>{//evento ao carregar o site
    displayMenuItems(menu);//chama função que adiciona os itens pegando do array
    displayMenuButtons();//chama função que adiciona categorias novas que vierem do array
    
});


function displayMenuItems(menuItens){//"menuItens" é o array "menu" 
  let displayMenu = menuItens.map((item)=>{//"map" pega todos os dados do array "menu", "item" é o que irá me retornar
    //retorna o novo item, substituindo pelos dados do array
    return `<article class="menu-item">
    <img src=${item.img} class="photo" alt=${item.title}>
    <div class="item-info">
        <header>
            <h4>${item.title}</h4>
            <h4 class="price">${item.price}</h4>
        </header>
        <p class="item-text">
        ${item.desc}
        </p>
    </div><!--item-info-->
</article><!--menu-item-->`;
});
displayMenu = displayMenu.join("");//junta os elementos do array colocando ""
sectionCenter.innerHTML = displayMenu;//adiciona os itens na seção pelo retorn do array
}

function displayMenuButtons(){
  const categories = menu.reduce((values,item)=>{
    if(!values.includes(item.category)){//se for diferente das categoria existente inclui
      values.push(item.category);//coloca a nova categoria no array
    }
    return values
  },
  ["all"])
  const categoryBtns = categories.map((category)=>{//pega todas as categorias do array "mesmo se for nova"
    return `<button class="filter-btn" type="button" data-id=${category}>${category}</button>`//botão dinâmico se tiver uma categoria diferente no array
  }).join("");
  container.innerHTML = categoryBtns;//adiciona a cateria pelos dados do array
  const filterBtns = container.querySelectorAll(".filter-btn")

  //filter
filterBtns.forEach((btn)=>{
  btn.addEventListener("click",(e)=>{
    const category = e.currentTarget.dataset.id;//botão clicado muda o filtro da categoria
    const menuCategory = menu.filter((menuItem)=>{
      //console.log(menuItem.category)
      if(menuItem.category === category){//retorna a categoria setando o "data-id"
        return menuItem
      }
    })
    //console.log(menuCategory)
    if(category === "all"){//se for "all" mostra todos produtos do array
      displayMenuItems(menu);
    }else{
      displayMenuItems(menuCategory);//senão filtra mostrando pelo nome da categoria
    }
  })
})
}