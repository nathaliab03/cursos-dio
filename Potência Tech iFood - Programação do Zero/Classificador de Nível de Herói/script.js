// Desafio - DIO - Classificador de Nível

let nickname = 'MelodyP'
let xpArmazenada = 35820

if(xpArmazenada >= 1 && xpArmazenada < 1000){
    console.log(`O herói de nome ${nickname} está no Nível de Ferro`)
  } else if(xpArmazenada > 1000 && xpArmazenada <= 2000) {
    console.log(`O herói de nome ${nickname} está no Nível de Bronze`)
 } else if(xpArmazenada > 2000 && xpArmazenada <= 5000) {
    console.log(`O herói de nome ${nickname} está no Nível de Prata`)
 } else if(xpArmazenada > 5000 && xpArmazenada <= 7000) {
    console.log(`O herói de nome ${nickname} está no Nível de Ouro`)
 } else if(xpArmazenada > 7000 && xpArmazenada <= 8000) {
    console.log(`O herói de nome ${nickname} está no Nível de Platina`)
 } else if(xpArmazenada > 8000 && xpArmazenada <= 9000) {
    console.log(`O herói de nome ${nickname} está no Nível de Ascendente`)
 } else if(xpArmazenada > 9000 && xpArmazenada <= 10000) {
    console.log(`O herói de nome ${nickname} está no Nível de Imortal`)
 } else if(xpArmazenada > 10000) {
    console.log(`O herói de nome ${nickname} está no Nível de Radiante`)
 } else {
  console.log('Quantidade de XP zerada ou negativa. Seu personagem está morto, tente novamente herói :D')
 }
