/****************************************************************************
Global variables
****************************************************************************/
//var curDate = getFormatedDate(new Date($.now()));

/****************************************************************************
*Add document ready on Page load
****************************************************************************/
$(function () {
    $(document).on('click', '#btnAddQuestion', function () {
        $('#masterModalTitle').text('Add / Update Question');
        $('#masterModal div:first').animate({ width: '80%' },2000);

        LetsStartAdmin.AdminQuestions.LoadAddUpdateQuestionPartial();
     
        $('#masterModal').modal({
            backdrop: 'static',
            keyboard: true
        });
    });


});


/****************************************************************************
*PM Dashboard Functions
****************************************************************************/
$.extend(LetsStartAdmin.AdminQuestions, {

    /****************************************************************************
    Function: LoadTopSectionCount()
    Purpose: Initiallize the value of global variable
    Developer: Ravi kumar
    ****************************************************************************/
    init: function () { },

    /****************************************************************************
   Function: ErrorMessage()
   Purpose: Error Message
   Developer: Ravi kumar
   ****************************************************************************/
    ErrorMessage: function () { },

    /****************************************************************************
    Function: Load()
    Purpose: This method is call the function on page load after displaying the Progress
    Flow:
    Developer: Ravi kumar
    ****************************************************************************/
    LoadAddUpdateQuestionPartial: function () {
        LetsStartAdmin.AjaxCall.AjaxCallPartialView('/Home/AddUpdateQuestionPartial', 'GET', true, null, LetsStartAdmin.AdminQuestions.LoadAddUpdateQuestionPartialSuccess, LetsStartAdmin.AdminQuestions.ErrorMessage);
    },
    LoadAddUpdateQuestionPartialSuccess: function (data) {
        $('#divMasterModalContent').html('');
        $('#divMasterModalContent').html(data);
    },
});