angular.module("lumx.search-filter").run(['$templateCache', function(a) { a.put('search-filter.html', '<div class="search-filter search-filter--{{ theme }}-theme"\n' +
    '     ng-class="{ \'search-filter--is-focused\': model,\n' +
    '                 \'search-filter--is-closed\': closed }">\n' +
    '    <div class="search-filter__container">\n' +
    '        <label class="search-filter__label"><i class="mdi mdi-magnify"></i></label>\n' +
    '        <input type="text" class="search-filter__input" placeholder="{{ placeholder }}" ng-model="model">\n' +
    '        <span class="search-filter__cancel" ng-click="clear()"><i class="mdi mdi-close-circle"></i></span>\n' +
    '    </div>\n' +
    '</div>');
	 }]);