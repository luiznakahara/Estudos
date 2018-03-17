module tsbr{
    export class Student implements IStudent, ISubscriber{
        constructor(public name: string, public email: string, public isSubscriber: boolean, public age: number){

        }
        register(): void{
            console.log('Aluno cadstrado com sucesso!')
        }
    }
}