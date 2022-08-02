// // // let index :  Declaracao da variavel contadora 
// // // index < array.length :  verificacao da quantidade, quantas vezes ira repetir 
// // // index++ : incremento 
// // // lenght : comprimento

// // for (let index = 0; index < 10; index++) {
 
// // }

// // array.forEach(element => {
    
// // });

// // while (condition) {
    
// // } // o codigo NAO executa ANTES de verificar

// // do {
    
// // } while (condition) // o codigo executa SIM ANTES de verificar

// let quantidade = 5

// for (let contador = 0; contador < quantidade; contador++) {
//     console.log(`o contador é ${contador +1}`)   
// }

// // while (contador < quantidade) { // while funcionando igual for 
// //     console.log("Opa, blz")
// //     contador++
// // }

// escreve par e o numero correspondente

let numeroDeAlunos =["a","b","c",'d',"e"]  
for (let contador = 0; contador < numeroDeAlunos.length; contador++) {
 
    if (contador == 0){
    console.log("Zero")
    
    } else if (contador % 2 ==0) { // % pega o resto da divisão
        console.log(`O numero ${contador} é par`)

    } else {
        console.log(`O numero ${contador} é impar`)
    }   

}