import { writable } from 'svelte/store';

export const selectedActivity = writable({
    id: '',
    title: '',
    date: '',
    description: '',
    category: '',
    city: '',
    venue: ''
});

selectedActivity.set(undefined);

export function setSelectedActivity(activity){
    selectedActivity.set({id : activity.id,
        title: activity.title,
        date: activity.date,
        description: activity.description,
        category: activity.category,
        city: activity.city,
        venue: activity.venue
    })
}

