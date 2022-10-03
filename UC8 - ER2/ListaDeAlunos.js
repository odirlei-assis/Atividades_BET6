let listaDeAlunos = ["Jessica","Odirlei","Thiago","Caique"];

for (let contador = 0; contador < listaDeAlunos.length; contador++) {
    
    // console.log(contador)

    if (contador == 0) {
        break
        console.log("o número atual é zero")
    }
    else if (contador % 2 == 0) {
        console.log("o número " + contador + " é par")
    }
    else{
        console.log(`o número ${contador} é impar`);
    }
    
}



for (let nome of listaDeAlunos) {
    console.log(`Esta pessoa se chama ${nome}`)
}


// let contador = 0

// while (contador < numeroDeAlunos) {
    
//     if (contador == 0) {
//         console.log("o número atual é zero")
//     }
//     else if (contador % 2 == 0) {
//         console.log("o número" + contador + "é par")
//     }
//     else{
//         console.log(`o número ${contador} é impar`);
//     }

//     contador ++
// }