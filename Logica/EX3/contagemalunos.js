let numeroDeAlunos =["a","b","c",'d',"e"] 
 
for (let contador = 0; contador < numeroDeAlunos.length; contador++) { // metodo 1
 
    if (contador == 0){
    console.log("Zero")
    
    } else if (contador % 2 ==0) { // % pega o resto da divisão
        console.log(`O numero ${contador} é par`)

    } else {
        console.log(`O numero ${contador} é impar`)
    }   
    
}

numeroDeAlunos.forEach(cadaItem => { // metodo 2 
        console.log(cadaItem)
})