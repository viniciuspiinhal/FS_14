// Sistema de Eventos, para empresa Savinis
// Atividade online # 2

let idade = 20 // idade minima 18 
let numeroParticipantes = 40 // numero maximo participantes 100
const dataHoje = new Date() // data UTC local
let dataEvento = new Date(2022,9,8) // data do evento
let palestrantes = ['Doutor', 'Mestre', 'Especialista', 'Graduado', 'Técnico'] // array lista de palestrantes
let participantes = ['Fulano da Silva', 'Beltrano de Maria', 'Ciclano José'] // array lista de participantes

if (idade >= 18) {
    console.log("Idade permitida")
    
        if (dataEvento > dataHoje) {
            console.log("A data do evento é permitida")
            
            if (numeroParticipantes <99) {
                console.log("Inscrição realizada")
                console.log ("Os palestrantes do evento são: " + palestrantes)
                console.log ("Os participantes do evento são: " + participantes)
                
            } else {
                console.log("Não há vagas no evento")
            }    
        } else {
            console.log("Evento já aconteceu, escolha outra data")
        }
    } else {
        console.log("Idade mínima 18 anos.")
} 