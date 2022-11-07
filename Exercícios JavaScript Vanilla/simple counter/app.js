//valor inicial contador
let count = 0;

//selecionar valor pelos botoes
const value = document.querySelector("#value");//variavel que pega o span pelo ID.
const btns = document.querySelectorAll(".btn");//variavel que pega todos os botões da mesma CLASSE.

btns.forEach((btn)=>{//função forEach percorre o Array de botões.
    btn.addEventListener("click",(e)=>{//função que adiciona o evento de click no botão.
        const styles = e.currentTarget.classList;// "e" elemento clicado, selecionado por sua CLASSE.
        if(styles.contains("decrease")){//verifica se contém "decrease" dentro do elemento.
            count--;
        }
        else if(styles.contains("increase")){//verifica se contém "increase" dentro do elemento.
            count++;
        }
        else{//senão for nenhum dos 2 cai no botão reset.
            count = 0;
        }
        if(count > 0){//altera cor com o contador maior que 0.
            value.style.color = "green";//variavel "value" pegada pelo ID
        }
        if(count < 0){//altera cor com o contador menor que 0.
            value.style.color = "red";
        }
        if(count === 0){
            value.style.color = "#222"
        }
        value.textContent = count;//altera o texto de "value" após as condicões.
    })
})
