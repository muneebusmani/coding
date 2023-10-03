const person = {
    fName: "Muneeb",
    lName: "Usmani",
    fullName: "Muneeb Usmani",
    age: "17",
    gender: "Male",
    occupation: "Student(loser/Brokey)",
    hobby: "games(bullshit)",
};

person.relations = {
    friends: [
        "ali",
        "ahmedRaza",
        "shoaib",
        "areej(was)",
    ],
    family: {
        mother: "Sharmeen Fahad",
        father: "Fahad Usmani",
        Brother: "Haseeb Usmani💞",
    }
}

person.roleModel = "Tate",
    person.currentStatus = [
        "brokey",
        "dork",
        "nerd",
        "loser",
        "selfHater",
        "**** addict",
    ],
    person.goal = [
        "strongAf",
        "powerFull",
        "flexiblity",
        "mobility",
        "getTheWorkDone",
        "beTheMan",
    ]
/*
we can also do all of the above  things when creating the variable,
but sometimes we will use this method
*/

person.fName = "Muneeb"
console.log(person);
/*
In This code we learned that we can do everything inside an object, i.e:
add,edit,remove its properties,methods
even if we use const or any other declaration method, 
this happens because the object isnt used as a value,
but it is assigned a location in memory which is then referenced to further usage,
thats why further usage alters the original object
*/