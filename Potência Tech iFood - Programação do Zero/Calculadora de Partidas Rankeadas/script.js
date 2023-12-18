function rankedCalculator(victory,defeat){
    let result = victory - defeat
    return result
}

function rank(){
    let rankResult = rankedCalculator(150,50)
    let level = ""
    if(rankResult <= 10){
        level = "Ferro"
    } else if(rankResult <= 20){
        level = "Bronze"
    } else if(rankResult <= 50){
        level = "Prata"
    } else if(rankResult <= 80){
        level = "Ouro"
    } else if(rankResult <= 90){
        level = "Diamante"
    } else if(rankResult <= 100){
        level = " Lendário"
    } else if(rankResult > 100){
        level = " Imortal"
    }

    return `O herói tem um saldo de ${rankResult} e está no nível ${level}`
}

console.log(rank())