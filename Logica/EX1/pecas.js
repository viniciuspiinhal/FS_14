let pesoPeca = 300 // peso deve ser maior que 100
let nomePeca = "disco" // tamanho do nome deve ser maior que 2 caracteres 
let quantidadePecas = 9 // quantidade de peças não pode ser maior que 10

if (quantidadePecas < 10) {
    console.log("A peça pode ser cadastrada")

    if (pesoPeca => 100) {
        console.log("Peso ok, a peça pode ser cadastrada")

        if (nomePeca.length > 2) {
            console.log("Nome da peça ok")
        } else { 
            console.log("Nome da peça mais curto que 3 caracteres")
        }
    } else {
        console.log("Peso inferior a 100, peça não pode ser cadastrada")
    }
} else {
    console.log("Quantidade de peças limite atingido")
}