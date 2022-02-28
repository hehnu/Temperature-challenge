const n = parseInt(readline()); // the number of temperatures to analyse
var inputs = readline().split(' '); // this is the array of split temperature 
var t;
for (let i = 0; i < n; i++) {
     t = parseInt(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
}

var temperatureOfZero = 0;
function closest(array){
  return array.reduce((a, b) => {
    let aDiff = Math.abs(a - temperatureOfZero);
    let bDiff = Math.abs(b - temperatureOfZero);
    
   if (Array.isArray(array) && array[0] === "" ) {
   return 0;
   }
   else if ( aDiff == bDiff){
     if (a > b){
       return a;
     }else{
       return b;
     }
   }//end of first else if (aDiff == bDiff)
   else if (aDiff > bDiff){
     return b;
   }else{
     return a;
   }
    
  }); }

let result = closest(inputs);
console.log(result);`

function closestToZero(numbers) {
    if(!numbers.length){
        return 0;
    }
    
    let closest = 0;
    
    for (let i = 0; i < numbers.length ; i++) { 
        if (closest === 0) {
            closest = numbers[i];
        } else if (numbers[i] > 0 && numbers[i] <= Math.abs(closest)) {
            closest = numbers[i];
        } else if (numbers[i] < 0 && - numbers[i] < Math.abs(closest)) {
            closest = numbers[i];
        }
    }
    
    return closest;
}

let result = closestToZero(inputs);

console.log(result || 0);
