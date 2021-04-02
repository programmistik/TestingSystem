
function jsAddAnswer(QuestionId, t, count, pn) {

    var obj = new Object();
    obj.Answers = [];

    if (t == 3) {
        var res = document.getElementById("AnsText").value;

        obj.Answers.push({
            "Text" : res
        });
    }
    else if (t == 2) {

        for (var i = 0; i < count; i++) {
            let res = document.querySelector("#var" + i);
            obj.Answers.push({
                "Text": res.value
            });
        }

    }
    else if (t == 1) {
        for (var i = 0; i < count; i++) {
            let res = document.querySelector("#ans" + i);
            if (res.checked) {
                obj.Answers.push({
                    "Text": i
                });

            }
            
        }
    }

    var jsonString = JSON.stringify(obj);

    $.ajax({
        url: '/Test/jsCreateOrUpdate',
        type: 'POST',
        data: { id: QuestionId, page: pn, jsonAnswers: jsonString},
        success: function (data) {
            //let btn = $('#like');
            //if (btn.hasClass('btn-danger')) {
            //    btn.removeClass('btn-danger').addClass('btn-success');
            console.log('ok');
        }
    });
}
