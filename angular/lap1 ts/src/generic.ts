function reverseArray<T>(arr: T[]): T[] {
    return arr.reverse();
}

const stringArray: string[] = ["apple", "banana", "orange"];
const reversedStringArray: string[] = reverseArray(stringArray);
console.log(reversedStringArray);

const numberArray: number[] = [1, 2, 3, 4, 5];
const reversedNumberArray: number[] = reverseArray(numberArray);
console.log(reversedNumberArray);