var darkSkyKey = config.SECRET_KEY;

new Vue({
    el: '#app',
    data() {
        return {
            cityInfo: null,
            loading: true,
            errored: false,
            options: [],
            selected: null,
            darkSkyInfo: null
        };
    },
    mounted() {
        // Consuming the Cities API
        axios
            .get('https://localhost:44354/api/city')
            .then(response => {
                this.cityInfo = response.data;
                this.cityInfo.forEach(obj => {
                    //Loading only the info we need
                    this.options.push({
                        text: obj.name,
                        value: [obj.latitude, obj.longitude]
                    });
                });
                console.log("Cities Info: " + JSON.stringify(this.cityInfo));
                console.log("Loaded Options: " + JSON.stringify(this.options));
            })
            .catch(error => {
                console.log(error);
                this.errored = true;
            })
            .finally(() => (this.loading = false));
    },
    methods: {
        //On change event for the select element
        callDarkSky(event) {
            //Time Machine Request from Dark Sky API docs: https://darksky.net/dev/docs
            let endpoint = `https://cors-anywhere.herokuapp.com/https://api.darksky.net/forecast/${darkSkyKey}/${this.selected[0]},${this.selected[1]},2019-07-04T12:00:00?exclude=minutely,hourly,daily,alerts,flags`;
            console.log(`City changed. Calling Dark Sky at endpoint: ${endpoint}`);
            axios
                .get(endpoint)
                .then(response => {
                    this.darkSkyInfo = response.data;
                    console.log(this.darkSkyInfo);
                })
                .catch(error => {
                    console.log(error);
                    this.errored = true;
                });
        }
    }
});