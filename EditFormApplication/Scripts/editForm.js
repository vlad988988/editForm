"use strict";

$(function () {
    var i = 0;
    $('.addField').click(function () {
        i++;
        var html2Add = "<div class='field'>" +
            "<div class='form-row'>" +
            "<div class='form-group col-md-5'>" +
            "<input name='Fields[" + i + "].HeadField' class='form-control form-control-inline' placeholder='Head of Field'>" +
            "</div>" +
            "<div class='form-group'>" +
            "<input type='submit' class='btn btn-default btn-xs col-md-1 ml-3' value='X' onclick='removeField(this);'><br>" +
            "</div>" +
            "</div>" +
            "<div class='content'>" +          
            "<textarea name='Fields[" + i + "].Selected' class = 'form-control form - control - inline' placeholder = 'placeholder'>" +
            "</textarea>" +
            "</div>"+
            "</div>" +
            "<div class='form-group'>" +
            "<div class='form-check text-right'>" +
            "<input name='Fields[" + i + "].Check' class='form-check-input' type='checkbox' value='true'/>Require?<br>" +
            "<input name='Fields[" + i + "].Check' type='hidden' value='false' />" +
            "</div>" +
            "</div>" +
            "</div>";
        $('#container').append(html2Add);
    });
});

//function addElement(elem) {
//    var parent = elem.parentNode;
//    var parentTwo = parent.parentNode;
//    var currentDiv = parentTwo.querySelector('.content');
//    var currentDivOne = currentDiv.querySelector('.contentOne');
//    var currentDivTwo = currentDiv.querySelector('.contentTwo');
//    var selectBox = elem.closest("select");
//    var selectedValue = selectBox.options[selectBox.selectedIndex].value;
//    if (selectedValue === "textarea" || selectedValue === "textarea2" || selectedValue === "textarea3") {
//        currentDivOne.style.display = 'none';
//        currentDivTwo.style.display = 'block';       
//    }
//    if (selectedValue === "input" || selectedValue === "input2") {
//        currentDivTwo.style.display = 'none';
//        currentDivOne.style.display = 'block';       
//    }
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


