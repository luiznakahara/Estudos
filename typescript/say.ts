interface IPerson{
    firstName: string;
    lastName: string
}

class Student{
    fullName: string;
    constructor(public firstName, public lastName){
        this.fullName = firstName + ' ' + lastName;
    }
}

function say(person: IPerson) {
    return "Hello" + person;
}

var user = new Student("Luiz", "Naka");

console.log(say(user));