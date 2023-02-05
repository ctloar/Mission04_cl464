// function called on the button click of the form
$("#btnClick").click(function () {

    // assigning variables to the values of the html input page
    assignment = $("#assignment").val();
    project = $("#project").val();
    quiz = $("#quiz").val();
    midterm = $("#midterm").val();
    final = $("#final").val();
    intex = $("#intex").val();

    // initializing variables to store calculated values
    master = 0;
    letter;

    // logic that calculates the final percentage
    master = (assignment / 2) + (project / 10) + (quiz / 10) + (midterm / 10) + (final / 10) + (intex / 10)

    // pop-up alert on the browser displaying the final percentage
    // alert("Final grade percentage: " + master + "%");

    // logic determining the letter grade associated with each percentage range
    if (master >= 94) {
        letter = 'A';
    }
    else if (master >= 90) {
        letter = 'A-'
    }
    else if (master >= 87) {
        letter = 'B+'
    }
    else if (master >= 84) {
        letter = 'B'
    }
    else if (master >= 80) {
        letter = 'B-'
    }
    else if (master >= 77) {
        letter = 'C+'
    }
    else if (master >= 74) {
        letter = 'C'
    }
    else if (master >= 70) {
        letter = 'C-'
    }
    else if (master >= 67) {
        letter = 'D+'
    }
    else if (master >= 64) {
        letter = 'D'
    }
    else if (master >= 60) {
        letter = 'D-'
    }
    else {
        letter = 'E'
    }

    // sends the letter grade to the html element with id 'letter'
    // document.getElementById("letter").innerHTML = letter;
    $("#letter").html(letter);
    alert(letter);
    
})