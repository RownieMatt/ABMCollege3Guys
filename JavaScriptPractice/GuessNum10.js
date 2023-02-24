function GuessNum10(a){
    var x=Math.floor((Math.random()*10)+1);
    if (x == a){
        console.log('You did it!' + a);
    }
    else if(x != a){
        console.log('The number is '+ x + ', try again.');

    }
}

GuessNum10(3);
