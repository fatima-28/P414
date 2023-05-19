$(document).ready(function () {
    $(".btn-load").click(function () {
        let parent = $(".parent-load")
        let take = $(".input-load").val();
        let skip = parent[0].children.length;
        console.log(parent[0].children)
        let productsCount = parseInt($(".parent-load").attr("data-list-count"));
        if (take <= 0 || take >= productsCount-skip) {
            take = skip;
        }
      
        $.ajax({
            url: `coffee/LoadMore?skip=${skip}&&take=${take}`,
            type: "Get",
            success: function (result) {
                
                $(parent).append(result);
                $(".input-load").val("");
                skip = parent[0].children.length;
               
                console.log(skip);
                console.log(productsCount);
                if (skip >= productsCount) {
                    $(".btn-load").addClass("d-none")
                    $(".input-load").addClass("d-none")

                }
            }
        })

    });
});
