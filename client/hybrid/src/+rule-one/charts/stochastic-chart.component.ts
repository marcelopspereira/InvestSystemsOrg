import { Component, Input, OnInit, OnChanges, SimpleChange } from '@angular/core';

//import { ChartsService } from './charts.service';
import { StochasticData } from './stochastic-data.model';

declare var google: any;

@Component({
    selector: 'stochastic-chart',
    template: 
    `
        <div id="stochastic-chart"></div>
        <footer class="legend">
            <ion-icon name="square"></ion-icon> {{ '_rule.Buy_line' | translate}} (%K)
            <ion-icon name="square"></ion-icon> {{ '_rule.Sell_line' | translate}} (%D)
        </footer>
    `,
})
export class StochasticChartComponent implements OnInit, OnChanges {
    @Input() title: string;
    @Input() data: StochasticData[];
    //chartsLoaded: boolean = false;

    constructor(/*private chartsService: ChartsService*/) {
        this.data = [];
    }

    ngOnInit() {
        // this.chartsService.load();
        // this.chartsService.chartsLoaded$.subscribe(loaded => {
        //     this.chartsLoaded = loaded;
        //     this.prepareDataAndDrawChart();
        // });
    }

    ngOnChanges(changes: { [propKey: string]: SimpleChange }) {
        if (changes['data'].currentValue) {
            this.prepareDataAndDrawChart();
        }
    }

    prepareDataAndDrawChart() {
        if (/*this.chartsLoaded && */this.data && this.data.length) {
            let rows = this.data.filter(sp => (sp.percentK != null && typeof sp.percentK !== 'undefined') || (sp.percentD != null && typeof sp.percentD !== 'undefined')).map(sp => sp.toRow());
            this.drawChart(rows);
        }
    }

    drawChart(rows) {
        var data = new google.visualization.DataTable();
        data.addColumn('date', 'Date');
        data.addColumn('number', 'Buy line (%K)');
        data.addColumn('number', 'Sell line (%D)');
        //data.addColumn('number', 'Close Price');

        data.addRows(rows);

        var options = {
            chart: {
                title: this.title
            },
            legend: {position: 'none'}, // TODO: bottom when it will be supported
            colors:['#4285F4','#F4B400']
        };

        var chart = new google.charts.Line(document.getElementById('stochastic-chart')); // TODO: some unique identifier?

        chart.draw(data, options);
    }
}