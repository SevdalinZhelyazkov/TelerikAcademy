function solveQuadraticEquation(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        firstRoot,
        secondRoot,
        discriminant;

    discriminant = (b * b) - (4 * a * c);

    if (discriminant < 0) {
        return 'no real roots';
    }

    discriminant = Math.sqrt(discriminant);
    firstRoot = ((-b - discriminant) / (2 * a));
    secondRoot = ((-b + discriminant) / (2 * a));

    if (firstRoot === secondRoot) {
        return 'x1=x2=' + firstRoot.toFixed(2);
    }

    if (firstRoot > secondRoot) {
        return 'x1=' + secondRoot.toFixed(2) + '; x2=' + firstRoot.toFixed(2);
    } else {
        return 'x1=' + firstRoot.toFixed(2) + '; x2=' + secondRoot.toFixed(2);
    }

    return 0;
}

console.log(solveQuadraticEquation(['2', '5', '-3']));
console.log(solveQuadraticEquation(['-0.5', '4', '-8']));
console.log(solveQuadraticEquation(['5', '2', '8']));
