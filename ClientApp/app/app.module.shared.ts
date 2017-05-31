import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
// import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
// import { CounterComponent } from './components/counter/counter.component';
import { AboutAppComponent } from './components/aboutapp/aboutapp.component';

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
