const validarUser = "gui";//Credenciais fixas ??  como esta como email talvez de erro!
const validarSenha = "g";

const loginForm = document.getElementById("loginForm");//Pega o formulario pelo id


//Esse "subimt" é o estado do botão.
loginForm.addEventListener("submit", (event) => {
    event.preventDefault();//Isso evita que a pagina fique recarregando automaticamente.

    //Capturar os valores dos campos
    const email = document.getElementById("userName").value;
    const senha = document.getElementById("password").value;

    //Verfica as credenciais 
    if(email == validarUser && senha == validarSenha){
        alert("Login bem sucedido!")
        window.location.href = "Front_end/login/index.html";//Aqui direciona para a pagina se o login estiver correto(Alterar a pagina)
    }else{
        alert("Credencias incorretas!")
    }
})
