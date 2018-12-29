'use strict';

/*
    Ensure
    This piece of code throws an err if the parameter given 
    is undefined. Returns the value if not.
*/
function ensure(value) {
    if (value === undefined) {
        throw 'Dude, that\'s an error!';
    }
    return value;
}
// ensure(undefined);
// console.log(ensure('Test'));

/*
Remove Property
This removes a specific property of a given object.
Returns whether it complished it or not.
*/
function removeProperty(obj, prop) {
    console.log(obj[prop]);
    if (obj[prop] === undefined) {
        return false;
    }
    return delete obj[prop];
}
// let Employee = {
//     firstname: 'John',
//     lastname: 'Doe'
// }
// console.log(Employee);
// console.log(removeProperty(Employee, 'firstname'));

/*
Check Digit
A recursive method to return the sum of all digits until one
gets just one digit. 
*/
/**
 * @prop {string} membershipId: The customer's membership ID.
 * @return {number} The check digit.
 */
function createCheckDigit(membershipId) {
    let length = membershipId.length;
    if (length !== undefined && length === 1) {
        return parseInt(membershipId);
    }
    let sum = 0;
    for (let i = 0; i < length; i++) {
        let int = parseInt(membershipId[i]);
        sum += int;
    }
    sum += '';
    return createCheckDigit(sum);
}
// console.log(createCheckDigit("55"));

/*
Date 
This formats a date in a specific asked for manner.
*/

function formatDate(userDate) {
    if (userDate === undefined || typeof userDate !== 'string') {
        throw 'Error, undefined';
    }
    let dateArr = userDate.split('/');
    // Quick and dirty, yet effective and efficient.
    // Interchanges array strings to fit API.
    if (dateArr[0].length == 1) {
        dateArr[0] = '0' + dateArr[0];
    }
    if (dateArr[1].length == 1) {
        dateArr[1] = '0' + dateArr[1];
    }
    let temp = dateArr[0];
    dateArr[0] = dateArr[2];
    dateArr[2] = temp;
    temp = dateArr[1];
    dateArr[1] = dateArr[2];
    dateArr[2] = temp;
    return dateArr.join('');
}

// console.log(formatDate("12/1/2014"));

/*
Image gallery
Implements an ES6 foreach of document nodes.
And adds an event listener to them.
*/

function setup() {
    // Write your code here.
    Array.from(document.getElementsByClassName('remove')).forEach(function (element) {
        element.addEventListener('click',
            () => {
                removeImage(element.parentNode);
            });
    });
}

function removeImage(node) {
    node.parentNode.removeChild(node);
}
// setup();
// console.log(document.getElementsByClassName('remove')[0]);
// document.getElementsByClassName("remove")[0].click();
// console.log(document.body.innerHTML);

/*
Closures.
Original script: 
function registerHandlers() {
  var as = document.getElementsByTagName('a');
  for (var i = 0; i < as.length; i++) {
    as[i].onclick = function() {
      alert(i);
      return false;
    }
  }
}
What is done is in order to encapsulate each variable in a different closure.
*/
function registerHandlers() {
    var as = document.getElementsByTagName('a');
    console.log(as[1]);
    let i = 0;
    for (let i = 0; i < as.length; i++) {
        (function () {
            as[i].onclick = () => {
                alert(i);
                return false;
            }
        })();
    }
}
// registerHandlers();

// Loop.
function appendChildren(decorateDivFunction) {
    var allDivs = document.getElementsByTagName("div");
    let length = allDivs.length;
    console.log(allDivs);
    for (var i = 0; i < length; i++) {
        var newDiv = document.createElement("div");
        decorateDivFunction(newDiv);
        allDivs[i].appendChild(newDiv);
    }
}

//appendChildren(function(div) {});
// console.log(document.body.innerHTML);

// Problem 1.
function arrayNums(num) {
    let arrMultiples = [];
    let sumMultiples = 0;
    for (let i = 3; i < num; i++) {
        if (i % 3 === 0 || i % 5 === 0) {
            arrMultiples.push(i);
            sumMultiples += i;
        }
    }
    return sumMultiples;
};
//  console.log(arrayNums(1000));

// REAL EXAM

// Katas

function reverseList(list) {
    let length = list.length;
    for (let i = 0; i < list.length/2; i++) {
        let temp = list[--length];
        list[length] = list[i];
        list[i] = temp;
    }
    return list;
}

console.log(reverseList([1,2,3,4]));