function PrimeNum(UpTo){
    if (UpTo == 1 || UpTo == 0){
        return false
    }
    for (var count = 2 ; count < UpTo; count++){
        if (UpTo % count == 0 ){
            return false
        }
    }
    return true
}

var M=100;

for (var count = 1; count <= M ; count ++){
    if(PrimeNum(count)){
        console.log(count);
    }
}

PrimeNum(3)