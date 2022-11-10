const btn = document.querySelector(".btn-add");
const container = document.querySelector(".container-anotacoes");
        
btn.addEventListener("click",()=>{
    container.innerHTML += '<div class="anotacao-single"><p></p><textarea placeholder="Sua nova anotação"></textarea></div>';

    const textArea = $(".anotacao-single").last().find("p");

    const date = new Date();
    const hh = date.getHours();
    const mm = date.getMinutes();
    const ss = date.getSeconds();

    const finalTime = hh+":"+mm+":"+ss;
    textArea.html(finalTime);
});

