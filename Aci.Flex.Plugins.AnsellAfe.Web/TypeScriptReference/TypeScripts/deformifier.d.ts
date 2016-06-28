declare class Deformifier {
    deformify(container?: JQuery): void;
    buildOptionsArray(inputToDeform: JQuery): Array<System.Tuple<string, string>>;
    parseCssClass(options: Array<System.Tuple<string, string>>): string;
    parseBindingText(inputToDeform: JQuery): string;
    buildDeformedElement(inputToDeform: any, bindingText: any, options: any): void;
}
