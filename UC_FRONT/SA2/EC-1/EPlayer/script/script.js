    // function mostrarMenu(){

    //     if (window.getComputedStyle(menu).display != "flex") {
    //         menu.style.display = "flex"
    //     } else {
    //         menu.style.display = "none"
    //     }
    // }

    function mostrarMenuJQuery(){
        $("#menu").toggle()      
    }

    function logar(){

        var login = document.getElementById("login").value;
        var senha = document.getElementById("senha").value;

        if(login == "admin" && senha == "admin"){
            alert('Sucesso');
            location.href = "home.html";
        }else{
            alert('Usuario ou senha incorretos');
        }

    }