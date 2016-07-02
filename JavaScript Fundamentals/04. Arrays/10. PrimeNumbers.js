// Sieve of Eratosthenes Algorithm
// Example input: ['123']

function findPrimeNumbers(args) {
    var i,
        j,
        n = +args[0],
        myArray = [],
        sqrt = Math.sqrt(n) | 0;

    for (i = 0; i <= n; i += 1) {
        myArray[i] = 1;
    }

    for (i = 2; i <= sqrt; i += 1) {
        if (myArray[i]) {
            for (j = i * i; j <= n; j += i) {
                myArray[j] = 0;
            }
        }
    }

    for (i = n; i >= 0; i -= 1) {
        if (myArray[i]) {
            return i;
        }
    }
}

console.log(findPrimeNumbers(['13']));