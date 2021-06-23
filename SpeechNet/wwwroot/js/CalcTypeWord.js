window.onload = () => {
    $(".btn-success").click(() =>
    {
        // исходное слово
        let txt = $("#text-input").val();

        // часть речи по мнению логики
        //txt = txt.toLowerCase(); // переводит слова в мелкие буквы иначе код робит не корктно. Да, хуита, поэтому здесь этот комент)

        $.ajax({
            url: "/wordTYPE",
            type: "POST",
            data: { word: txt },
            dataType: 'JSON',
            contentType: 'application/x-www-form-urlencoded',
            success: function (responce) {

                $("#result").text(responce);
                
            },
            error: function (responce) {        
                if (responce.status == 1) alert("Поле пустое! " + `${responce.statusText} StatusCode: ${responce.status}`);
                else alert("Неизвестная ошибка " + `${responce.statusText} StatusCode: ${responce.status}`);
                $("#repeat").click();
            }
        });
        $("a").click(() => { $("a").removeClass("active") });

    });
};