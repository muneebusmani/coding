const myArray=[
    1,
    1,
    1,
    1,
]
//myArray=""; //This wont work
let randomInts=Math.random()
randomInts*=10;
randomInts=Math.round(randomInts)

myArray.unshift(randomInts)//insert that value on 0 index
console.log(myArray)

/*
All of the bullshit and piece of crap basically means :
you can work inside the current datatype when using const 
but cant change datatype, when we use const in non primitive datatype

That reference bullshit from php cant work here so dont headbutt on wall,
js doesnt allow custom references, only non primitve datatypes are used as reference
*/