class Hero{
    constructor(name, age, race) {
        this.name = name;
        this.age = age;
        this.race = race;
    }

    ataque() {
        
        switch(this.race) {
            case 'mago':
                console.log(`O tipo mago atacou usando magia`);
                break
            case 'guerreiro':
                console.log(`O tipo guerreiro atacou usando espada`);
                break
            case 'monge':
                console.log(`O tipo monge atacou usando artes marciais`);
                break;
            case 'ninja':
                console.log(`O tipo ninja atacou usando shuriken`);
                break
        }
    }
}

let naruto = new Hero('Uzumaki Naruto', 33, 'ninja')
naruto.ataque()

let gandalf = new Hero('Gandalf', 3000, 'mago')
gandalf.ataque()