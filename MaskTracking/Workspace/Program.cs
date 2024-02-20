using Business.Adapters;
using Business.Concrete;
using Entities.Concrete;

var ptt = new PttManager(new MernisServiceAdapter());
var person = new Person("firstName", "lastName", 12345678901, 9999);

ptt.GiveMask(person);