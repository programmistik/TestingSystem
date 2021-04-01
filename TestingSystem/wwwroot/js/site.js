
function jsAddAnswer(QuestionId, t) {

    var obj = new Object();

    if (t == 3) {
        let res = document.querySelector("#AnsText");
    }
    else if (t == 2) {

    }
    else if (t == 1) {

    }
    let res = document.querySelector("#AnsText");

    
    obj.name = "Raj";
    obj.age = 32;
    obj.married = false;
    var jsonString = JSON.stringify(obj);

    $.ajax({
        url: '/Test/jsCreateOrUpdate',
        type: 'POST',
        data: { id: QuestionId, Answers: jsonString},
        success: function (data) {
            //let btn = $('#like');
            //if (btn.hasClass('btn-danger')) {
            //    btn.removeClass('btn-danger').addClass('btn-success');
            console.log('ok');
        }
    });
}
