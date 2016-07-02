function biggestOfFive(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        d = +args[3],
        e = +args[4];

    var biggest = a;

    if (biggest < b) {
        biggest = b;
    }
    if (biggest < c) {
        biggest = c;
    }
    if (biggest < d) {
        biggest = d;
    }
    if (biggest < e) {
        biggest = e;
    }

    return biggest;
}

console.log(biggestOfFive(['-2', '-22', '1', '0', '0']));
console.log(biggestOfFive(['-2', '4', '3', '2', '0']));