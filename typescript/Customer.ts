class Person {
    constructor(public document: string){}
}

class Company {
    constructor(public companyName: string){}
}

interface ICompany extends Company {
    register(): void;
}

class FoodCompany implements ICompany {
    constructor(public companyName: string){}    
    register(): void {}
}

class Customer extends Person{
    static points: number = 0;
    private _name: string;

    constructor(myname: string, public document: string) {
        super(document);
        this._name = myname;
        Customer.points; //ACESSO A VARIAVEIS ESTATICAS!
    }
    
    //get|set implicito por default, posso explicitar-los e operar validações e tudo mais
    get name(): string {
        return this._name;
    }
    set name(newName: string) {
        this._name = newName;
    }

    //'?' indica nullable
    register(age: number, document: string, teste?: number): String {
        return 'Registrado com sucesso!'
    }

    register2(): void {

    }
}

var c = new Customer('Luiz', '12345678901');
c.name = '';
console.log(c.name);
c.register(25, 'bla');
c.register2();

//ACESSO A VARIAVEIS ESTATICAS!
Customer.points;

var comp = new FoodCompany('Salgadinhos');