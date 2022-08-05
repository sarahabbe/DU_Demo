{"api_version":"1.2","model":"passports","release":"ga","schema":{"classification":{},"extraction":[{"color":"#0099bf","hidden":false,"hotkey":"p","multi_line":false,"multi_page":"first_occurrence","name":"passport-no","post_processing":"first_span","scoring":"exact_match","split_items":false,"type":"id-no"},{"color":"#7f7920","hidden":false,"hotkey":"l","multi_line":true,"multi_page":"highest_confidence","name":"last-name","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#234010","hidden":false,"hotkey":"f","multi_line":true,"multi_page":"highest_confidence","name":"first-name","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#ff0088","hidden":false,"hotkey":"n","multi_line":false,"multi_page":"highest_confidence","name":"nationality","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#00bfb3","hidden":false,"hotkey":"s","multi_line":false,"multi_page":"highest_confidence","name":"sex","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#7f5140","hidden":false,"hotkey":"b","multi_line":false,"multi_page":"first_occurrence","name":"birth-date","post_processing":"first_span","scoring":"exact_match","split_items":false,"type":"date"},{"color":"#ff8c40","hidden":false,"hotkey":"i","multi_line":true,"multi_page":"highest_confidence","name":"birth-place","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#f2ff40","hidden":false,"hotkey":"u","multi_line":false,"multi_page":"first_occurrence","name":"issued-date","post_processing":"first_span","scoring":"exact_match","split_items":false,"type":"date"},{"color":"#383040","hidden":false,"hotkey":"a","multi_line":false,"multi_page":"highest_confidence","name":"address","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#eabfff","hidden":false,"hotkey":"t","multi_line":true,"multi_page":"highest_confidence","name":"authority","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#7f1100","hidden":false,"hotkey":"e","multi_line":false,"multi_page":"first_occurrence","name":"expiration-date","post_processing":"first_span","scoring":"exact_match","split_items":false,"type":"date"},{"color":"#bfeaff","hidden":false,"hotkey":"m","multi_line":true,"multi_page":"highest_confidence","name":"mrz","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#20403e","hidden":false,"hotkey":",","multi_line":true,"multi_page":"highest_confidence","name":"state","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#005580","hidden":false,"hotkey":"-","multi_line":false,"multi_page":"highest_confidence","name":"state-code","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#110040","hidden":false,"hotkey":"d","multi_line":true,"multi_page":"highest_confidence","name":"document-type","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#686080","hidden":false,"hotkey":"o","multi_line":false,"multi_page":"highest_confidence","name":"document-type-code","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"},{"color":"#0066ff","hidden":false,"hotkey":"r","multi_line":false,"multi_page":"highest_confidence","name":"personal-id","post_processing":"first_span","scoring":"levenshtein","split_items":false,"type":"string"}]},"tags":[{"name":"passport-no","type":"id-no"},{"name":"last-name","type":"string"},{"name":"first-name","type":"string"},{"name":"nationality","type":"string"},{"name":"sex","type":"string"},{"name":"birth-date","type":"date"},{"name":"birth-place","type":"string"},{"name":"issued-date","type":"date"},{"name":"address","type":"string"},{"name":"authority","type":"string"},{"name":"expiration-date","type":"date"},{"name":"mrz","type":"string"},{"name":"state","type":"string"},{"name":"state-code","type":"string"},{"name":"document-type","type":"string"},{"name":"document-type-code","type":"string"},{"name":"personal-id","type":"string"}]}