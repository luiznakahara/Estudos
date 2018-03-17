/// <reference path="ISubscriber.ts"/>
/// <reference path="IStudent.ts"/>
/// <reference path="Student.ts"/>

module tsbr{
    function run(student: IStudent){
        student.register();
    }


    var student = new Student('Luiz', 'luiz.nakahara@hotmail.com', false, 25);
    run(student);
}
