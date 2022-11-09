const toggleBtn = document.querySelector(".sidebar-toggle");//pega o botao do menu
const closeBtn = document.querySelector(".close-btn");//pega o botao fechar
const sidebar = document.querySelector(".sidebar");//elemento que vai ser modificado

toggleBtn.addEventListener("click",()=>{
    /*console.log(sidebar.classList);//função raiz no evento click
    if(sidebar.classList.contains("show-sidebar")){//verifica se tem a classe "show-sidebar"
        sidebar.classList.remove("show-sidebar");//se já tiver remove ela
    }else{
        sidebar.classList.add("show-sidebar");//senão tiver adiciona ela
    }*/
    sidebar.classList.toggle("show-sidebar");//faz tudo em 1 linha
});

closeBtn.addEventListener("click",()=>{//ao clicar no "x" remove a classe que exibe o menu
    sidebar.classList.remove("show-sidebar")
});