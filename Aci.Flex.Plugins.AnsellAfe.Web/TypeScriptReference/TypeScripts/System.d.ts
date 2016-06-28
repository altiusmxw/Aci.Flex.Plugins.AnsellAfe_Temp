declare module System {
    class Guid {
        private id;
        private static emptyGuid;
        constructor(id: string);
        static empty(): Guid;
        static emptyId(): string;
        static newGuid(): Guid;
        static regex(format?: string): RegExp;
        private static s4();
        toString(format: string): string;
        valueOf(): string;
    }
    class Tuple<T1, T2> {
        Item1: T1;
        Item2: T2;
        m_Item1: T1;
        m_Item2: T2;
        constructor(item1: T1, item2: T2);
    }
    class StringTuple extends Tuple<String, String> {
        constructor(item1: string, item2: string);
    }
}
interface ILiteEvent<T> {
    on(handler: {
        (data?: T): void;
    }): any;
    off(handler: {
        (data?: T): void;
    }): any;
}
declare class LiteEvent<T> implements ILiteEvent<T> {
    private handlers;
    on(handler: {
        (data?: T): void;
    }): void;
    off(handler: {
        (data?: T): void;
    }): void;
    trigger(data?: T): void;
}
