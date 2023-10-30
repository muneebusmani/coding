const prompt = require('prompt-sync')();

const dictionary={
    lol:"laugh out loud",
    lmao:"laughing my ass off",
    u:"you",
    "fk off":"fuck off",
    "stfu":"shut the fuck up",
}
/*
Method one
*/
console.log(dictionary.lmao);


/*
Method two:
this can be used when we want to insert a dynamic value, eg. value which user typed in prompt,
*/
let word=prompt("Enter The word you want to find the full form of:");
console.log(dictionary[word]);
//here we passed searched the value inside the variable i.e which we got from prompt
