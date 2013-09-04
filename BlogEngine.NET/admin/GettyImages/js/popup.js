// JavaScript Document
var day = "";
	//Add categories
	var arrayTags = [""];
    var index = 0;
    var step = 5;
    var current = 0;
    var visible = 4;
    var speed = 300;
    var liSize = 96;
    var carousel_height = 80;
    var divSize = liSize * visible;
    
//Load all getty images by API
function LoadGettyImages() {
    var key = $("#search").val();
    if (key == '' || key == null || key == 'search gettyimages for more...') {
        key = "";
    }
    var data = { key: key };

    $.ajax({
        url: window.SiteVars.ApplicationRelativeWebRoot + "admin/AjaxHelper.aspx/LoadGetttyImages",
        data: JSON.stringify(data),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: onAjaxBeforeSend,
        success: function (msg) {
            
            $('#GettyImagesSearch').setTemplateURL(window.SiteVars.ApplicationRelativeWebRoot + 'Templates/gettyimagessearch.htm?v=2', null, { filter_data: false });
            $('#GettyImagesSearch').processTemplate(msg);
            
            /************* CAROUSEL 2 ****************/
            var maximum1 = $('#my_carousel1 ul li').size();
            var ulSize = (liSize + 15) * maximum1;

            $('#my_carousel1 ul').css("width", ulSize + "px").css("left", -(current * liSize)).css("position", "absolute");

            $('#my_carousel1').css("width", divSize + "px").css("height", carousel_height + "px").css("visibility", "visible").css("overflow", "hidden").css("position", "relative");


            $('.carousel_btnnext1').click(function () {
                if (current + step < 0 || current + step > maximum1) { return true; }
                else {
                    current = current + step;
                    $('#my_carousel1 ul').animate({ left: -((liSize + 12) * current) }, speed, null);
                }
                return false;
            });

            $('.carousel_btnprev1').click(function () {
                if (current - step < 0 || current - step > maximum1) { return true; }
                else {
                    current = current - step;
                    $('#my_carousel1 ul').animate({ left: -((liSize + 12) * current) }, speed, null);
                }
                return false;
            });

            //Auto load the first images
            $('#my_carousel1 .carousel-thumbs li:first').addClass('ad-active');
            var imglink = $('#my_carousel1 .carousel-thumbs li:first').find('a');
            var imgattr = $('#my_carousel1 .carousel-thumbs li:first').find('img');
            $('#carousel_viewimage1').html($('<span></span><img src = "' + imglink.attr('href') + '">'));
            $('#carousel_viewimage1').append('<div class="caption"><a class="btnuploadimage1" onclick="UploadImageToKaltura();"></a><span class="imgtitle">' + imgattr.attr('title') + '</span><span class="imgalt">' + imgattr.attr('alt') + '</span></div>');

            $('.carousel-wrapper-thumbs a').click(function (e) {
                e.preventDefault();
                var img = $(this).find('img');
                $('.carousel-wrapper-thumbs .carousel-thumbs li').removeClass('ad-active');
                $(this).parents('li').addClass('ad-active');
                $('#carousel_viewimage1').html($('<img>').attr({ 'src': this.href }).fadeIn(1000));
                $('#carousel_viewimage1').append('<div class="caption"><a class="btnuploadimage1" onclick="UploadImageToKaltura();"></a><span class="imgtitle">' + img.attr('title') + '</span><span class="imgalt">' + img.attr('alt') + '</span></div>');
            });
            /************* END CAROUSEL 2 ****************/
        }
    });
    return false;
}
//Load all getty images client
function LoadGettyImagesClient() {
    var custId = $("#search").val();
    if (custId == '' || custId == null || custId == 'search gettyimages for more...') {
        custId = "1";
    }
    var data = { custId: custId };

    $.ajax({
        url: window.SiteVars.ApplicationRelativeWebRoot + "admin/AjaxHelper.aspx/LoadGetttyImagesClient",
        data: JSON.stringify(data),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: onAjaxBeforeSend,
        success: function (msg) {

            $('#GettyImagesClient').setTemplateURL(window.SiteVars.ApplicationRelativeWebRoot + 'Templates/gettyimagesclient.htm?v=2', null, { filter_data: false });
            $('#GettyImagesClient').processTemplate(msg);

            /************* CAROUSEL 1 ****************/
            var maximum = $('#my_carousel ul li').size();
            var ulSize = (liSize + 15) * maximum;
            $('#my_carousel ul').css("width", ulSize + "px").css("left", -(current * liSize)).css("position", "absolute");

            $('#my_carousel').css("width", divSize + "px").css("height", carousel_height + "px").css("visibility", "visible").css("overflow", "hidden").css("position", "relative");

            $('.carousel_btnnext').click(function () {
                if (current + step < 0 || current + step > maximum) { return true; }
                else {
                    current = current + step;
                    $('#my_carousel ul').animate({ left: -((liSize + 12) * current) }, speed, null);
                }
                return false;
            });

            $('.carousel_btnprev').click(function () {
                if (current - step < 0 || current - step > maximum) { return true; }
                else {
                    current = current - step;
                    $('#my_carousel ul').animate({ left: -((liSize + 12) * current) }, speed, null);
                }
                return false;
            });

            //Auto load the first images
            $('#my_carousel .carousel-thumbs li:first').addClass('ad-active');
            var imglink = $('#my_carousel .carousel-thumbs li:first').find('a');
            $('#carousel_viewimage').html($('<span></span><img src = "' + imglink.attr('href') + '">'));

            $('#my_carousel .carousel-thumbs a').click(function (e) {
                e.preventDefault();
                // Active highlight thumbnail
                $('#my_carousel .carousel-thumbs li').removeClass('ad-active');
                $(this).parents('li').addClass('ad-active');

                $('#carousel_viewimage').html($('<span></span><img>').attr({ src: this.href }).fadeIn(1000));
                $('#carousel_viewimage').append('<div class="caption"></div>');
            });

            /************* END CAROUSEL 1 ****************/
        }
    });
    return false;
}

function UploadImageToKaltura() {

    var flag = true;
    var urlPreview = $('#my_carousel1 .carousel-nav .carousel-thumbs li.ad-active .center-thumb img').attr('src');
    var gettyImageId = $('#my_carousel1 .carousel-nav .carousel-thumbs li.ad-active .center-thumb img').attr('class');
    if (gettyImageId == "image0") {
        return false;
    }

    $("#my_carousel .carousel-nav .carousel-thumbs li .center-thumb img").each(function (index, domEle) {
        var gettyId = $('#my_carousel .carousel-nav .carousel-thumbs li .center-thumb img').eq(index).attr('class');
        if (gettyId != undefined && gettyId == gettyImageId) {
            alert("This image is exist in photo gallery");
            flag = false;
            return false;
        }
    });

    if (flag) {
        var data = { urlPreview: urlPreview, gettyImageId: gettyImageId };
        $.ajax({
            url: window.SiteVars.ApplicationRelativeWebRoot + "admin/AjaxHelper.aspx/UploadImageToKaltura",
            data: JSON.stringify(data),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            beforeSend: onAjaxBeforeSend,
            success: function () {
                LoadGettyImagesClient();
            }
        });
    }
    
    return false;
}
function InsertToPost() {
    var urlPreview = $('#my_carousel .carousel-nav .carousel-thumbs li.ad-active .center-thumb img').attr('src');
    var gettyImageId = $('#my_carousel .carousel-nav .carousel-thumbs li.ad-active .center-thumb img').attr('class');
    if (gettyImageId == "image0") {
        return false;
    }
    var data = { urlPreview: urlPreview};
    $.ajax({
        url: window.SiteVars.ApplicationRelativeWebRoot + "admin/AjaxHelper.aspx/DownloadKalturaImages",
        data: JSON.stringify(data),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: onAjaxBeforeSend,
        success: function (msg) {
            appendFile(msg.d);
            $.colorbox.close();
        }
    });

    return false;
}

