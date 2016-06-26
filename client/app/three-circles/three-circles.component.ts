import { Component, OnInit, trigger, state, style, transition, animate } from '@angular/core';

import { MeaningCircleComponent } from './meaning-circle.component';
import { CircleDataService } from './circle-data.service'

import { Store } from '@ngrx/store';
import { ADD_AREA } from './area.reducer'


@Component({
    moduleId: module.id,
    selector: 'three-circles',
    templateUrl: 'three-circles.component.html',
    styleUrls: ['three-circles.component.css'],
    directives: [MeaningCircleComponent],
    providers: [CircleDataService],
    animations: [
        trigger('flyInOut', [
            state('in', style({ opacity: 1, transform: 'translateX(0)' })),
            transition('void => *', [
                style({
                    opacity: 0,
                    transform: 'translateX(-100%)'
                }),
                animate('0.2s ease-in')
            ]),
            transition('* => void', [
                animate('0.2s 10 ease-out', style({
                    opacity: 0,
                    transform: 'translateX(100%)'
                }))
            ])
        ])
    ]
})
export class ThreeCirclesComponent implements OnInit {
    public areas;

    constructor(
        private store: Store<any>
    ) {
        store
            .select(state => state.areas)
            .subscribe(areas => {
                debugger;
                this.areas = areas;
            });
    }

    ngOnInit() { }

    onAddArea(area) {
        console.log(area);
        this.store.dispatch({ type: ADD_AREA, payload: area });
    }
}