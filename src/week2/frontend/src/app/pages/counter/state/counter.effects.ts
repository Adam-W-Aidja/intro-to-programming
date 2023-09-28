import { Injectable } from "@angular/core";
import { Actions, createEffect } from "@ngrx/effects";
import { tap } from "rxjs";

 

@Injectable({
    providedIn: 'root'
})
export class CounterEffects {

 

 

    logEmAll$ = createEffect(() => this.actions$.pipe(
        tap(action => console.log(`Got an action of the ${action.type}`))

 

    ), { dispatch: false })

 

    constructor(private readonly actions$: Actions) { }

 

}