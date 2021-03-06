﻿/// <reference path="../sweetalert.min.js" />
/// <reference path="~/scripts/jquery-3.1.1.intellisense.js" />
$(document)
    .ready(function() {
        $(".btn-plus").on("click", function () {

            var currentRow = $(this).closest("tr");
            var currentVal = currentRow.find("td:eq(3) input").val();
           // var buttonValue = currentRow.find("td:eq(4) button").text();
            $(this).parent().siblings("input").val(parseInt(currentVal) + 1);
        });
        $(".btn-minus").on("click", function () {

            var currentRow = $(this).closest("tr");
            var currentVal = currentRow.find("td:eq(3) input").val();
            if (currentVal>0) {
                $(this).parent().siblings("input").val(parseInt(currentVal) - 1);
            }
        });
        //
        $("#btnPlaceOrder")
            .on("click",
                function () {
                    ItemArray();

                });

        $(document)
            .on("click",".btnEdit",
                function () {
                    var currentRow = $(this).closest("tr");
                    currentRow.find("td:eq(4) button").first().prop("disabled", false);
                    currentRow.find("td:eq(4) button").first().text("Add to Order List");
                    currentRow.find("td:eq(4) button").removeClass("btn-success");
                    currentRow.find("td:eq(3) button").prop("disabled", false);
                    currentRow.find("td:eq(3) input").prop("disabled", false);
                    currentRow.find("td:eq(4) button[name='btnEdit']").hide();
                    currentRow.find("td:eq(3) input").focus();

                    // Checking with git

                });

        $(".btn-primary.btnAddorder")
          .on("click",
              function () {
                  var currentRow = $(this).closest("tr");
                  var currentVal = currentRow.find("td:eq(3) input").val();
                  if (currentVal > 0) {
                      currentRow.find("td:eq(4) button").text("Added");
                      currentRow.find("td:eq(4) button").addClass("btn btn-success");
                      currentRow.find("td:eq(4) button").prop("disabled", true);
                      currentRow.find("td:eq(3) button").prop("disabled", true);
                      currentRow.find("td:eq(3) input").prop("disabled", true);
                      var r = $('<button type="submit" class="btn btn-primary btnEdit" name="btnEdit" id="btnEdit">Edit</button>');
                      currentRow.find("td:eq(4)").append(r);

                  } else {
                      window.swal("","Please order at least one unit from each of the item", "error");
                   
                  }
              });
    });


function ItemArray() {
    var itemArry =[];

    $("tr.productItems")
    .each(function () {
            var currrentRow = $(this);

            var itemArrayObj = {
                ProductId: currrentRow.find("td:eq(1)").text(),
                ProductDescription: currrentRow.find("td:eq(2)").text(),
                Units: currrentRow.find("td:eq(3) input").val()
                    }
                    itemArry.push(itemArrayObj);
                });
}