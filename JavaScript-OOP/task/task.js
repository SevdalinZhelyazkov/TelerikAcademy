function solve() {


    const VALIDATOR = {
        validateName: function(name) {
            if (typeof name !== 'string' || name.length < 1 || name.length > 24 || name.match(/[^a-zA-Z0-9 ]/)) {
                throw new Error('Invalid name!');
            }
        },
        validateDescription: function(description) {
            if (typeof description !== 'string') {
                throw new Error('Invalid description!');
            }
        },
        validateVersion: function(version) {
            if (isNaN(version) || version < 0) {
                throw new Error('Invalid version!');
            }
        },
        validateRating: function(rating) {
            if (isNaN(rating) || rating < 1 || rating > 10) {
                throw new Error('Invalid rating!');
            }
        },
        validateNewVersion: function(newVersion, currentVersion) {
            if (newVersion <= currentVersion) {
                throw new Error('New version is not greater than the old one!');
            }
        },
        validateCount: function(count) {
            count = count || 10;
            if (count < 0) {
                throw new Error('Invalid count!');
            }
        },
        validateHostname: function(hostname) {
            if (typeof hostname !== 'string' || hostname.length < 1 || hostname.length > 32) {
                throw new Error('Invalid hostname!');
            }
        },
        validateApps: function(apps) {
            if (!Array.isArray(apps)) {
                throw new Error('Apps is not an array!');
            }
            for (let i = 0, len = apps.length; i < len; i += 1) {
                if (!(apps[i] instanceof App)) {
                    throw new Error('Invalid app!');
                }
            }
        }
    };

    class App {
        constructor(name, description, version, rating) {
            this.name = name;
            this.description = description;
            this.version = version;
            this.rating = rating;
        }

        get name() {
            return this._name;
        }
        set name(value) {
            VALIDATOR.validateName(value);
            this._name = value;
        }

        get description() {
            return this._description;
        }
        set description(value) {
            VALIDATOR.validateDescription(value);
            this._description = value;
        }

        get version() {
            return this._version;
        }
        set version(value) {
            VALIDATOR.validateVersion(value);
            this._version = value;
        }

        get rating() {
            return this._rating;
        }
        set rating(value) {
            VALIDATOR.validateRating(value);
            this._rating = value;
        }

        release(releaseOptions) {
            if (typeof(releaseOptions) === 'number') {
                VALIDATOR.validateNewVersion(releaseOptions, this.version);
                this.version = releaseOptions;
            }

            if (typeof(releaseOptions) === 'object') {
                VALIDATOR.validateVersion(releaseOptions.version);
                VALIDATOR.validateNewVersion(releaseOptions.version, this.version);
                this.version = releaseOptions.version;

                if (typeof(releaseOptions.description !== 'undefined')) {
                    VALIDATOR.validateDescription(releaseOptions.description);
                    this.description = releaseOptions.description;
                }

                if (typeof(releaseOptions.rating !== 'undefined')) {
                    VALIDATOR.validateRating(releaseOptions.rating);
                    this.rating = releaseOptions.rating;
                }
            }

            throw new Error('Invalid release parameter');
        }
    }

    class Store extends App {
        constructor(name, description, version, rating) {
            super(name, description, version, rating);
            this.apps = [];
            this.appsUploadDate = [];
        }

        get apps() {
        	return this._apps;
        }
        set apps(value) {
        	this._apps = value;
        }

        get appsUploadDate() {
        	return this._appsUploadDate;
        }
        set appsUploadDate(value) {
        	this._appsUploadDate = value;
        }

        uploadApp(app) {
            if (!(app instanceof App)) {
                throw new Error('app is not an instance of App');
            }

            const index = this.apps.findIndex(c => c.name === app.name);

            // Add app if not found
            if (index < 0) {
                this.appsUploadDate[app.name] = Date.now();
                this.apps.push(app);
                return this;
            }

            // Update app if found
            let currentApp = apps[index];
            VALIDATOR.validateNewVersion(app.version, currentApp.version);
            currentApp.version = app.version;
            currentApp.description = app.description;
            currentApp.rating = app.rating;

            return this;
        }

        takedownApp(name) {
            const index = this.apps.findIndex(c => c.name === name);

            if (index < 0) {
                throw new Error('App does not exist in the store!');
            }

            this.apps.splice(index, 1);

            return this;
        }

        search(pattern) {
            return this.apps.slice().filter(c => c.name.match(pattern)).sort((x, y) => x.name.localeCompare(y.name));
        }

        listMostRecentApps(count) {
            VALIDATOR.validateCount(count);
            const mostRecentApps = this.apps.slice().sort((x, y) => this.appsUploadDate[x.name] < this.appsUploadDate[y.name]);

            return mostRecentApps.splice(0, count);
        }

        listMostPopularApps(count) {
            VALIDATOR.validateCount(count);
            const mostPopularApps = this.apps.slice().sort((x, y) => this.appsUploadDate[x.name] < this.appsUploadDate[y.name]).sort((x, y) => x.rating < y.rating);
            
            return mostPopularApps.splice(0, count);
        }
    }

    class Device {
        constructor(hostname, apps) {
            this.hostname = hostname;
            this.apps = apps;
        }

        get hostname() {
            return this._hostname;
        }
        set hostname(value) {
            VALIDATOR.validateHostname(value);
            this._hostname = value;
        }

        get apps() {
            return this._apps;
        }
        set apps(value) {
            VALIDATOR.validateApps(value);
            this._apps = value;
        }

        search(pattern) {
            return this.apps.slice().filter(c => c.name.match(pattern)).sort((x, y) => x.name.localeCompare(y.name));
        }

        install(name) {
            // Check if app is installed on this device
            const index = this.apps.findIndex(c => c.name === name);

            if (index >= 0) {
            	return this;
            }

            let storeIndex,
                appIndexInStore,
                currentVersion,
                latestVersion = 0,
                isInStore = false;

            const InstalledStores = this.apps.slice().filter(c => c instanceof Store);

            // Check if app is in some of the stores on this device
            for (let i = 0, len = InstalledStores.length; i < len; i += 1) {
                let currentStore = InstalledStores[i];

                for (let j = 0, lenStore = currentStore.apps.length; j < lenStore; j += 1) {
                    let currentStoreApp = currentStore.apps[j];

                    if (currentStoreApp.name === name) {
                        currentVersion = currentStoreApp.version;
                        isInStore = true; // Find app in some store
                    }

                    if (currentVersion > latestVersion) {
                        latestVersion = currentVersion;
                        storeIndex = i;
                        appIndexInStore = j;
                    }
                }
            }

            if (!isInStore) {
                throw new Error('App is not found in installed stores!');
            }

            const appToAdd = this.InstalledStores[storeIndex].apps[appIndexInStore];
            this.apps.push(appToAdd);

            return this;
        }

        uninstall(name) {
            const index = this.apps.findIndex(c => c.name === name);

            if (index < 0) {
                throw new Error('App to uninstall not found!');
            }

            // Uninstall app
            this.apps.splice(index, 1);

            return this;
        }

        listInstalled() {
            return this.apps.slice().sort((x, y) => x.name.localeCompare(y.name));
        }

        update() {
            let appToUpdate,
            	storeIndex,
                appIndexInStore,
                currentVersion,
                currentStore,
                currentStoreApp,
                latestVersion,
                isInStore = false;

            const InstalledStores = this.apps.slice().filter(c => c instanceof Store);

            for (let k = 0, lenApps = this.apps.length; k < lenApps; k += 1) {
            	appToUpdate = this.apps[k];

            	if (appToUpdate instanceof Store) {
            		continue;
            	}

            	latestVersion = appToUpdate.version;

            	for (let i = 0, lenStores = InstalledStores.length; i < lenStores; i += 1) {
            		currentStore = InstalledStores[i];

            		for (let j = 0, lenStoreApps = currentStore.apps.length; j < lenStoreApps; j += 1) {
                        currentStoreApp = currentStore.apps[j];

                        if (currentStoreApp.name === name) {
                            currentVersion = currentStoreApp.version;
                            isInStore = true; // Find app in some store
                        }

                        if (currentVersion > latestVersion) {
                            latestVersion = currentVersion;
                            storeIndex = i;
                            appIndexInStore = j;
                        }
                    }
            	}

	            if (!isInStore) {
	                continue;
	            }

	            let newApp = this.InstalledStores[storeIndex].apps[appIndexInStore];
	            appToUpdate.description = newApp.description;
	            appToUpdate.rating = newApp.rating;
	            appToUpdate.version = newApp.version;
            }

            return this;
        }
    }

    return {
        createApp(name, description, version, rating) {
            return new App(name, description, version, rating);
        },
        createStore(name, description, version, rating) {
            return new Store(name, description, version, rating);
        },
        createDevice(hostname, apps) {
            return new Device(hostname, apps);
        }
    };
}

// Submit the code above this line in bgcoder.com
module.exports = solve;
