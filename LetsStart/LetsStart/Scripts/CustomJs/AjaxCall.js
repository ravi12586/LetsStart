/// <summary>
/// This js file have all service methods calling using ajax.
/// </summary>
$.extend(LetsStartAdmin.AjaxCall, {

    ajaxBaseURL: '/Admin',

    /// <summary>
    ///  initiallize the value of global variable
    /// </summary>
    /// <param name="ajaxBaseURL">Url of service domain.</param>
    init: function (ajaxBaseURL) {
        this.ajaxBaseURL = ajaxBaseURL;
    },

    /// <summary>
    /// ServiceController
    /// </summary>
    /// <param name="endPoint">url of service method name, which is created into service</param>
    /// <param name="userName">User email id</param>
    /// <param name="password">User Password</param>
    /// <param name="success">The object of success method.</param>
    /// <param name="fail">The object of Fail method.</param>
    /// <returns>login user details</returns>
    AjaxCall: function (endPoint, type, async, jsonObjects, success, fail) {
        try {

            $.ajax({
                url: this.ajaxBaseURL + endPoint,
                data: JSON.stringify(jsonObjects),
                type: type,
                async: async,
                timeout: 1000000000,
                contentType: "application/json",
                dataType: "json",
                error: function (e) {
                    alert("list failed!");
                },
                success: function (list) {
                    success(list);
                },
                failure: function (list) {

                    fail(list);
                }
            });
        }
        catch (e) {
            alert(e.toString());
        }
    },

    /// <summary>
    /// ServiceController
    /// </summary>
    /// <param name="endPoint">url of service method name, which is created into service</param>
    /// <param name="userName">User email id</param>
    /// <param name="password">User Password</param>
    /// <param name="success">The object of success method.</param>
    /// <param name="fail">The object of Fail method.</param>
    /// <returns>login user details</returns>
    AjaxCallParam: function (endPoint, type, async, jsonObjects, success, fail, param) {
        try {

            $.ajax({
                url: this.ajaxBaseURL + endPoint,
                data: JSON.stringify(jsonObjects),
                type: type,
                async: async,
                timeout: 1000000000,
                contentType: "application/json",
                dataType: "json",
                error: function (e) {
                    alert("list failed!");
                },
                success: function (list) {
                    success(list, param);
                },
                failure: function (list) {

                    fail(list);
                }
            });
        }
        catch (e) {
            alert(e.toString());
        }
    },

    /// <summary>
    /// ServiceController (This method is used to call controller method which returns partial view with model)
    /// </summary>
    /// <param name="endPoint">url of service method name, which is created into service</param>
    /// <param name="userName">User email id</param>
    /// <param name="password">User Password</param>
    /// <param name="success">The object of success method.</param>
    /// <param name="fail">The object of Fail method.</param>
    /// <returns></returns>
    AjaxCallPartialView: function (endPoint, type, async, jsonObjects, success, fail, param) {
        try {
            $.ajax({
                async: async,
                url: this.ajaxBaseURL + endPoint,
                type: type,
                dataType: "html",
                data: jsonObjects,
                error: function (e) {
                    alert("list failed!");
                },
                success: function (list) {
                    success(list, param);
                },
                failure: function (list) {
                    fail(list);
                }
            });
        }
        catch (e) {
            alert(e.toString());
        }
    },

});


