let helper = {
    compile: compile
};

export default helper;

function compile(str: string, context: any = null) {
    if (context == null) { return; }
    for(let pro  in context){
        if(!context.hasOwnProperty(pro)){continue;}
        str = str.replace(
            "{{"+pro+"}}",
            context[pro]
        );
    }
    return str;
}