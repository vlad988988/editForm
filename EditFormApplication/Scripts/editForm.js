"use strict";

$(function () {
    var i = 0;
    $('.addField').click(function () {
        i++;
        var html2Add = "<div class='field'>" +
            "<div class='form-row'>" +
            "<div class='form-group col-md-5'>" +
            "<input name='Fields[" + (i + 1) + "].HeadField' class='form-control form-control-inline' placeholder='Заголовок поля'>" +
            "</div>" +
            "<select name=TypeField[" + i + "] class='selectBox form-control col-md-6 ml-4' onchange='addElement(this);'>" +
            "<option value='textarea'>Один из списка</option>" +
            "<option value='textarea'>Несколько из списка</option>" +
            "<option value='textarea'>Раскрывающийся список</option>" +
            "<option value='input'>Текст-строка</option>" +
            "<option value='input'>Текст-абзац</option>" +
            "</select>" +
            "<div class='form-group'>" +
            "<input type='submit' class='btn btn-default btn-xs col-md-1 ml-3' value='X' onclick='removeField(this);'><br>" +
            "</div>" +
            "</div>" +
            "<div class='content'>" +

            "</div>" +
            "<div class='form-group'>" +
            "<div class='form-check text-right'>" +
            "<input name='Check[" + i + "]' class='form-check-input' type='checkbox' required/>Обязательный вопрос<br>" +
            "</div>" +
            "</div>" +
            "</div>";
        $('#container').append(html2Add);
    })
})

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

//function addField(btn) {
//  var form = btn.closest("form");
//  if (form) {
//    var div = form.querySelector(".field");
//    if (div) {
//      var divCreated = document.createElement("div");
//      divCreated.className = div.className;
//      divCreated.innerHTML = div.innerHTML;
//      document.getElementById('container').appendChild(divCreated);
//    }
//  }
//}


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


