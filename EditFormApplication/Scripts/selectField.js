"use strict";

//function addElement (elem) {
//  var parent = elem.parentNode;
//  var parentTwo = parent.parentNode;
//  var currentDiv = parentTwo.querySelector('.content'); 
//  var selectBox = elem.closest("select");
//  var selectedValue = selectBox.options[selectBox.selectedIndex].value;
//  var newElem = document.createElement(selectedValue);
//  currentDiv.innerHTML = newElem.outerHTML;
//  currentDiv.firstChild.className = "form-control col-md-8";
//  currentDiv.firstChild.setAttribute(name, "Des");
//}

function addElement(elem) {
    var parent = elem.parentNode;
    var parentTwo = parent.parentNode;
    var currentDiv = parentTwo.querySelector('.content');
    var currentDivOne = currentDiv.querySelector('.contentOne');
    var currentDivTwo = currentDiv.querySelector('.contentTwo');
    var selectBox = elem.closest("select");
    var selectedValue = selectBox.options[selectBox.selectedIndex].value;
    // alert(selectedValue);
    if (selectedValue === "textarea") {
        currentDivOne.style.display = 'none';
        currentDivTwo.style.display = 'block';
    }
    if (selectedValue === "input") {
        currentDivTwo.style.display = 'none';
        currentDivOne.style.display = 'block';
    }
}

function addField(btn) {
  var form = btn.closest("form");
  if (form) {
    var div = form.querySelector(".field");
    if (div) {
      var divCreated = document.createElement("div");
      divCreated.className = div.className;
      divCreated.innerHTML = div.innerHTML;
      document.getElementById('container').appendChild(divCreated);
    }
  }
}

function removeField(btn) {
    var divCount = document.getElementsByClassName('field').length;
    if (divCount === 1) {
       return alert("error");
    }
  var div = btn.closest(".field");
  if (div) {
    div.remove();
  }
}


