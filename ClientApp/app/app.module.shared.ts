import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './component/app/app.component'
import { NavMenuComponent } from './component/navmenu/navmenu.component';
import { HomeComponent } from './component/home/home.component';
// import { FetchDataComponent } from './component/fetchdata/fetchdata.component';
// import { CounterComponent } from './component/counter/counter.component';
import { AboutAppComponent } from './component/aboutapp/aboutapp.component';

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        // CounterComponent,
        // FetchDataComponent,
        AboutAppComponent,
        HomeComponent
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            // { path: 'counter', component: CounterComponent },
            // { path: 'fetch-data', component: FetchDataComponent },
            {path: 'aboutapp', component: AboutAppComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
};
